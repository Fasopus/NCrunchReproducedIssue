namespace ApplicationLibrary
{
    public class StringConcatenator
    {
        public string ConcatenateStringData(StringData stringData)
        {
            var concatentatedString = stringData.String1 + stringData.String2;

            return concatentatedString;
        }

    }
}
