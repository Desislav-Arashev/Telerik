namespace Code_Formatting.Contracts
{
    public interface IWritable
    {
        void Write(string message);

        void WriteLine(string message);
    }
}
