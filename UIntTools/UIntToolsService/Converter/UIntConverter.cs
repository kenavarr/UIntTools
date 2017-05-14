namespace UIntToolsService
{
    public class UIntConverter : IUIntConverter
    {

        public string ConvertUIntToRomanNumeral(uint uIntValue)
        {
            if (uIntValue == 0)
                throw new UIntConverterException();

            RomanTool romanTool = new RomanTool();
            return romanTool.GetRomanNumber(uIntValue);
        }
    }
}
