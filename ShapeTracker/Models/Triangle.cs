namespace ShapeTracker.Models
{
  public class Triangle
  {
    private int _side1;
    public int Side1
    {
      get { return _side1; }
      set { _side1 = value; }
    }
    public int Side2 { get; set; }
    private int _side3;

    public Triangle(int length1, int length2, int length3)
    {
      _side1 = length1;
      Side2 = length2;
      _side3 = length3;
    }

    public int GetSide3()
    {
      return _side3;
    }

    public void SetSide3(int newValue)
    {
      _side3 = newValue;
    }

    public string CheckType()
    {
      return "not a triangle";
    }
  }
}