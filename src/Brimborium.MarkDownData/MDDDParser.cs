using Markdig;
using Markdig.Syntax;
using Markdig.Syntax.Inlines;

using System.Diagnostics;

namespace Brimborium.MarkDownData;

public class MDDDParser {
    private string _Content;
    private MDDSchema _Schema;

    public MDDDParser(string content, MDDSchema schema) {
        this._Content = content;
        this._Schema = schema;
    }

    public MDDDocument ParseDocument() {
        var markdownDocument = Markdig.Markdown.Parse(this._Content, true);
        foreach (var item in markdownDocument) {
            if (item is IBlock block) {
                Debug.Assert(item is not IInline);
            }
            if (item is IInline inline) {
                Debug.Assert(item is not IBlock);
            }
        }
        
        return new MDDDocument();
    }
}