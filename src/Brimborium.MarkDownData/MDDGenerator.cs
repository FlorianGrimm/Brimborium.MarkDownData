
namespace Brimborium.MarkDownData;

public class MDDGenerator {
    private MDDSchema _Schema;

    public MDDGenerator(MDDSchema schema) {
        this._Schema = schema;
    }

    public string GenerateDocument(MDDDocument value) {
        return """
Preamble

# Title 1
""";
    }
}