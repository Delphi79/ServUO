namespace Server.Items
{
    [FlipableAttribute(0x491B, 0x4930)]
    public class LlamaTopiary : Item
    {
        public override int LabelNumber { get { return 1070878; } } // a decorative topiary

        [Constructable]
        public LlamaTopiary() : base(0x491B)
        {
            this.Weight = 1.0;
            this.Name = ("a llama topiary");
        }

        public LlamaTopiary(Serial serial) : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write(0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }
    }
}