namespace HandlingException;
public class DivideZero
{
    public int Divide(int a, int b)
    {
        if(b == 0)
        {
            throw new System.ArithmeticException("Cannot Divide by zero.");
        }

        return a/b;
    }
}
