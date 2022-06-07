namespace InterpreterDesignPattern
{
    public class Context
    {
        public string AircraftModel { get; set; } = "";
        public bool IsAircraft { get; set; } = false;

        public Context(string _ac_model)
        {
            AircraftModel = _ac_model;
        }

        public int GetLenght()
        {
            return AircraftModel.Length;
        }

        public string GetLastChar()
        {
            return AircraftModel[AircraftModel.Length - 1].ToString();
        }

        public string GetFirstChar()
        {
            return AircraftModel[0].ToString();
        }
    }
}
