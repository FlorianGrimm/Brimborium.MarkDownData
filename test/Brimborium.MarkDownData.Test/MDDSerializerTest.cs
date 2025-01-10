using System.Runtime.CompilerServices;

namespace Brimborium.MarkDownData.Test;

public class MDDSerializerTest {
    /*
    [Fact]
    public void SerializeIsEmtpy()
    {
        MDDSchema schema = new();
        MDDDocument document = new();
        var act = MDDSerializer.Serialize(document, schema);
        Assert.Equal("", act);
        //Verify(act)
    }
    */

    [Fact]
    public Task SerializePreambleAndH1() {
        MDDSchema schema = new();
        MDDDocument document = new();
        document.Preamble = "Preamble";
        var act = MDDSerializer.Serialize(document, schema);
        return Verify(act);
    }


    [Fact]
    public void DeserializePreambleAndH1() {
        MDDSchema schema = new();
        var act = MDDSerializer.Deserialize("""
Preamble

# Title 1
""", schema);
        Assert.NotNull(act);

        //return Verify(act);
    }

    //D:\github.com\FlorianGrimm\Brimborium.MarkDownData\documentation\sample.md
    [Fact]
    public void DeserializeSample() {
        Assert.True(File.Exists(GetFilePath(@"documentation\sample.md")));
        var mdContent = System.IO.File.ReadAllText(GetFilePath(@"documentation\sample.md"));
        MDDSchema schema = new();
        var mddDocument = MDDSerializer.Deserialize(mdContent, schema);
        Assert.NotNull(mddDocument);
        //Assert.Equal(2, mddDocument.ListNode.Count);
    }

    private static string GetFilePath(string relativePath) {
        return Path.Combine(GetSolutionDirectory(), relativePath);
    }

    private static string GetSolutionDirectory([CallerFilePath] string? sourceFilePath = default) {
        return Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(sourceFilePath))) ?? throw new Exception("should not be");
    }
}

