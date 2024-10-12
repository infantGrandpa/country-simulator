namespace Abraham.CountrySimulator.Resources
{
    [System.Serializable]
    public class ResourceStack
    {
        public Resource resource;
        public int amount;
        
        public ResourceStack(Resource resource, int amount)
        {
            this.resource = resource;
            this.amount = amount;
        }
        public ResourceStack(Resource resource)
        {
            this.resource = resource;
            amount = 0;
        }
    }
}
