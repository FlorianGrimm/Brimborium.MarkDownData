namespace Brimborium.MarkDownData;

public static class MDDSerializer {
    public static string Serialize(MDDDocument value, MDDSchema schema){
        MDDGenerator generator = new(schema);
        return generator.GenerateDocument(value);
    }

    public static MDDDocument Deserialize(string mddContent, MDDSchema schema){
        MDDDParser parser = new(mddContent, schema);
        return parser.ParseDocument();
    }
}
