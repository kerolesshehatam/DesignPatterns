namespace BridgePattern.Bridge.Json
{
    public class JSONPresenter : IPresenter
    {
        private JsonConverter _jsonConverter;
        public JSONPresenter(JsonConverter jsonConverter)
        {
            _jsonConverter = jsonConverter;
        }
        public void OperationImplementation()
        {
            _jsonConverter.GetJson();
        }
    }
}
