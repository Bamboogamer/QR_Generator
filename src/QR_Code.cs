namespace QR_Generator
{
    public class QR_Code
    {
        // Attributes
        private int version;
        private int[ , ] QR_Matrix;

        // Constructor
        public QR_Code(int version)
        {
            var size = 0;
            this.version = version;
            
            size = version switch
            {
                // Change size of QR code based on Version
                1 => 21, 2 => 25, 3 => 29, 4 => 33, 5 => 37, 
                6 => 41, 7 => 45, 8 => 49, 9 => 53, 10 => 57,
                
                11 => 61, 12 => 65, 13 => 69, 14 => 73, 15 => 77,
                16 => 81, 17 => 85, 18 => 89, 19 => 93, 20 => 97,
                
                21 => 101, 22 => 105, 23 => 109, 24 => 113, 25 => 117,
                26 => 121, 27 => 125, 28  => 129, 29 => 133, 30 => 137,
                
                31 => 141, 32 => 145, 33 => 149, 34 => 153, 35 => 157,
                36 => 161, 37 => 165, 38  => 169, 39 => 173, 40 => 177,
                _ => size
            };
            
            QR_Matrix = new int[size, size];
        }
    }
}