namespace MathExtension;

using Microsoft.CodeAnalysis;

[Generator]
public class ExampleSourceGenerator : ISourceGenerator
{
    public void Initialize(GeneratorInitializationContext context)
    {
        
    }

    public void Execute(GeneratorExecutionContext context)
    {
        string source = @"
namespace SourceGeneratorExample;

public partial class MathHelper
{
    public int Subtract(int x1, int x2){
        return x1 - x2;
    }
}";
        context.AddSource("genSource", source);
    }
}