namespace DZ_PT_WinForms_3_2
{
    public class Goods
    {
        string goodsName;
        string goodsCharacter;
        string goodsAbout;
        double goodsPrice;
        public string GoodsName
        {
            get { return goodsName; }
            set { goodsName = value; }
        }
        public string GoodsCharacter
        {
            get { return goodsCharacter; }
            set { goodsCharacter = value; }
        }
        public string GoodsAbout
        {
            get { return goodsAbout; }
            set { goodsAbout = value; }
        }
        public double GoodsPrice
        {
            get { return goodsPrice; }
            set { goodsPrice = value; }
        }
        public Goods()
        {
            GoodsName = "unknown";
            GoodsCharacter = "unknown";
            GoodsAbout = "unknown";
            GoodsPrice = 0;
        }
        public Goods(string goodsName, string goodsCharacter, string goodsAbout, double goodsPrice)
        {
            GoodsName = goodsName;
            GoodsCharacter = goodsCharacter;
            GoodsAbout = goodsAbout;
            GoodsPrice = goodsPrice;
        }
        public override string ToString()
        {
            return GoodsName + " Цена: " + GoodsPrice;
        }
    }
}
