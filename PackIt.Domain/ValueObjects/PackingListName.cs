namespace PackIt.Domain.ValueObjects
{
    public record PackingListName     {
        public string Value { get; }

        public PackingListName(string value)
        {
            Value = value;
        }

    }
}
