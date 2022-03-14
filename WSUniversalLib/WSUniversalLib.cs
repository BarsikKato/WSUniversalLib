using System;

namespace WSUniversalLib
{
    public class Calculation
    {
        public int GetQuantityForProduct(int productType, int materialType, int count, float width, float length)
        {
            float product_type, material_type;
            if (productType == 1)
                product_type = 1.1f;
            else if (productType == 2)
                product_type = 2.5f;
            else if (productType == 3)
                product_type = 8.43f;
            else
                return -1;
            if (materialType == 1)
                material_type = 0.003f;
            else if (materialType == 2)
                material_type = 0.0012f;
            else
                return -1;
            if (width <= 0 || length <= 0 || count <= 0)
                return -1;
            float firstResult = width * length * product_type * count;
            float finalResult = firstResult + (firstResult * material_type);
            return (int)finalResult;
        }
    }
}
