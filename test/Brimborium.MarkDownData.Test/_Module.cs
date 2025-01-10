using System.Runtime.CompilerServices;

namespace Brimborium.MarkDownData.Test;

public class _Module
{
    [ModuleInitializer]
    public static void Initialize() =>
        VerifyDiffPlex.Initialize();

}
