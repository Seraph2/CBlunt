java -jar antlr-4.7.2-complete.jar -Dlanguage=CSharp -o csharp Calculator.g4 -no-listener -visitor
cd csharp
ren CalculatorVisitor.cs ICalculatorVisitor.cs