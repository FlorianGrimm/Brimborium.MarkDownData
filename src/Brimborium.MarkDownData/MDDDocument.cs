namespace Brimborium.MarkDownData;

public class MDDDocument {
    public List<IMDDNode> ListNode { get; set; } = new();
    public string? Preamble {
        get {
            return null;
        }
        set {
            if (value != null) {
                if ((0 < this.ListNode.Count)
                    && (this.ListNode[0].NodeType == MDDNodeType.TriviaPreamble)
                    && (this.ListNode[0] is MDDTrivia trivia)
                    ) {
                    trivia.Text = value;
                } else {
                    this.ListNode.Add(new MDDTrivia() { NodeType = MDDNodeType.TriviaPreamble, Text = value });
                }
            } else {
                if (0 < this.ListNode.Count) {
                    if (this.ListNode[0].NodeType == MDDNodeType.TriviaPreamble) {
                        this.ListNode.RemoveAt(0);
                    }
                }
            }
        }
    }
}

public enum MDDNodeType {
    Invalid,
    TriviaPreamble,
    Trivia,
    Value,
}
public interface IMDDNode {
    MDDNodeType NodeType { get; }
}

public class MDDTrivia : IMDDNode {
    public MDDNodeType NodeType { get; set; }
    public string Text { get; set; } = string.Empty;
}
public class MDDValue : IMDDNode {
    public MDDNodeType NodeType { get; set; }
}