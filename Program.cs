﻿// See https://aka.ms/new-console-template for more information
//Build command: dotnet build --configuration Release --runtime linux-x64 --self-contained
using System;
using System.Text;
using Antlr_language;
using Antlr_language.Content;
using Antlr4.Runtime;
using Antlr_language.ast;
using Antlr_language.ast.structure;

namespace Antlr_language
{
    class Program
    {
        static void Main (string[] args) {
            var filePath = "";
            var outputFileName = "";
            bool debugMode = false;
            bool verbose = false;
            for (int i = 0; i < args.Length; i++) {
                switch (args[i]) {
                    case "-d":
                        debugMode = true;
                        break;
                    case "-v":
                        verbose = true;
                        break;
                    default:
                        //Last argument must be outputPath except if only 1 none flag argument.
                        if (i == args.Length - 1) {
                            if (filePath == "") {
                                filePath = Path.GetFullPath(args[i]);
                            } else {
                                outputFileName = args[i];
                            }
                        //Last argument must be outputPath
                        } else if (i == args.Length - 2) {
                            filePath = Path.GetFullPath(args[i]);
                        } else {
                            throw new ArgumentException("To many non defined flag arguments.");
                        }
                        break;
                }
            }
            if (File.Exists(filePath) == false)
                throw new FileNotFoundException();
            
            
            var fileContents = File.ReadAllText(filePath);
            AntlrInputStream inputStream = new AntlrInputStream(fileContents);
            var vestaLexer = new VestaLexer(inputStream);
            CommonTokenStream commonTokenStream = new CommonTokenStream(vestaLexer);
            VestaParser vestaParser = new VestaParser(commonTokenStream);
            var vestaContext = vestaParser.program();
            
            if (debugMode) {
                var visitor = new VestaVisitor(true);
                visitor.Visit((vestaContext));
            } else {
                var visitor = new VestaVisitor(false);
                AstBuilder builder = new AstBuilder();
                ASTDecorator Decorator = new ASTDecorator(new SymbolTable(verbose));
                CodeGenVisitor CodeGenerator = new CodeGenVisitor(2);
                
                //Semantic analysis
                visitor.Visit((vestaContext));

                AbstractNode AST = builder.Visit((vestaContext));
                Decorator.Visit((dynamic)AST);
                CSharpBuilder CSB = new CSharpBuilder(outputFileName);
                CSB.AcceptStringBuilder(CodeGenerator.Visit((dynamic)AST));
                CSB.OutputResult();
            }

            Console.WriteLine("Completed, press enter to continue...");
            Console.Read();

        }
    }
}
