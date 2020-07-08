using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _106_Classwork8;

namespace _106_Quiz7
{
    public static class ShapeType    //靜態類別, 不能被實體化 (new)
    {
        public enum Geo       //使用 enum 增加程式的可讀性
        {
            UNKNOWN = -1, BALL = 0, CUBE, CYLINDER, PYRAMID
        };
        public enum Material   //使用 enum 增加程式的可讀性
        {
            UNKNOWN = -1, Al = 0, Fe, Pb
        };
    }


    abstract class Shape3D      //抽象類別, 不能被實體化 (new)
    {
        protected static int _amount;  //被繼承的欄位 (資料成員)需宣告為 protected
        //protected double _density;     //被繼承的欄位 (資料成員)需宣告為 protected, _material 與 _density 有相關性 故取消
        protected ShapeType.Geo _geoType;
        protected ShapeType.Material _materialType; //_material 與 _density 有相關性
        public Shape3D()
        {
            _materialType = ShapeType.Material.UNKNOWN;
            _amount++;
        }

        public Shape3D(ShapeType.Material mType)
        {
            _materialType = mType;
            _amount++;
        }
       
        public static int Amount     //要給其他類別取用, 故宣告為 public
        {
            get { return _amount; }
        }
        public ShapeType.Material MaterialType     //要給其他類別取用, 故宣告為 public
        {
            get { return _materialType; }
        }
        public ShapeType.Geo GeoType     //要給其他類別取用, 故宣告為 public
        {
            get { return _geoType; }
        }
        public abstract double Volume();  //抽象函式, 子類別需進行 override
    
        public double Weight()         //開放給其他類別使用, 故宣告成 public
        {
            return Density() * Volume();
        }
        public double Density()        //根據 Material Type 計算 density
        {
            return MaterialTable.Density(_materialType);
        }
        public abstract string ShapeProperty();   //抽象函式, 子類別需進行 override

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
