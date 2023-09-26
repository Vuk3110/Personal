namespace Entity.Entiteti
{
    public class Entitet<TId>
    {
        public TId ID { get; protected set; }

        public Entitet(TId id)
        {
            ID = id;
        }

        public Entitet()
        {
        }
    }
}