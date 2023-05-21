public class CheckListData {
    public CheckListData()
    {
        Console.WriteLine("checklistdata 객체 생성 완료");
        Description = "";
        Title = "";
        Status = "";
    }

    public enum ResultStatus { Good = 1, Vulnerable = 0, NotApplicable = -1 /*해당사항 없음, Don't care*/ };
    private int MajorIndex;
    // Setter
    public void setMajorIndex(int setValue)
    {
        MajorIndex = setValue;
    }
    // Getter
    public int getMajorIndex()
    {
        return MajorIndex;
    }
    private int MinorIndex;
    public void setMinorIndex(int setValue)
    {
        MinorIndex = setValue;
    }
    // Getter
    public int getMinorIndex()
    {
        return MinorIndex;
    }
    private string Title;
    public void setTitle(string setValue)
    {
        Title = setValue;
    }
    // Getter
    public string getTitle()
    {
        return Title;
    }
    private string Description;
    public void setDescription(string setValue)
    {
        Description = setValue;
    }
    // Getter
    public string getDescription()
    {
        return Description;
    }
    private string Status;
    public void setStatus(string setValue)
    {
        Status = setValue;
    }
    // Getter
    public string getStatus()
    {
        return Status;
    }
    private int Value;
    public void setValue(int setValue)
    {
        Value = setValue;
    }
    // Getter
    public int getValue()
    {
        return Value;
    }
    private int Result;
    public void setResult(int setValue)
    {
        Result = setValue;
    }
    // Getter
    public int getResult()
    {
        return Result;
    }
}