using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _106_Quiz7
{
    static class ShapeType
    {
        public enum Geo
        {
            UNKNOW = -1, BALL = 0, CUBE, CYLINDER, PYRAMID
        }
        public enum Material
        {
            UNKNOW = -1, Al = 0, Fe, Pb
        }
    }

    abstract class Shape3D
    {
        protected static int _amount;  //被繼承的欄位 (資料成員)需宣告為 protected
        //protected double _density;     //被繼承的欄位 (資料成員)需宣告為 protected
        protected ShapeType.Geo _geo;
        protected ShapeType.Material _material;
        public Shape3D()
        {
            //_density = 0;
            _material = ShapeType.Material.UNKNOW;
            _amount++;
        }

        public Shape3D(ShapeType.Material mType)
        {
            //Density = density;
            _material = mType;
            _amount++;
        }
        public ShapeType.Geo Geo
        {
            get { return _geo; }
        }
        public ShapeType.Material Material
        {
            get { return _material; }
        }
        public double Density()
        {
            double density = 0;
            switch (_material)
            {
                case ShapeType.Material.Al:
                    density = 2.7;
                    break;
                case ShapeType.Material.Fe:
                    density = 7.87;
                    break;
                case ShapeType.Material.Pb:
                    density = 11.3;
                    break;
                default:
                    break;
            }
            return density;
        }
        public static int Amount     //要給其他類別取用, 故宣告為 public
        {
            get { return _amount; }
        }

        public abstract double Volume();  //虛擬函式, 子類別需進行 override
        //{
        //    return 0;
        //}
        public double Weight()         //開放給其他類別使用, 故宣告成 public
        {
            return Density() * Volume();
        }
        public abstract string ShapeProperty();   //虛擬函式, 子類別需進行 override
        //{
        //    return "";
        //}
        protected string Property()      //只讓子類別呼叫, 故宣告 protected, 抽出子類別重複的程式碼進行重構
        {
            string str="";
            str += string.Format("{0,8:F2}", Density());
            str += '\t';
            str += string.Format("{0,8:F2}", Volume());
            str += '\t';
            str += string.Format("{0,8:F2}", Weight());
            return str;
        }

    }
}
