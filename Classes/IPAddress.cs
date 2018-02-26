using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class IpAddress
    {
        #region Properties
        // 192.168.12.2
        private string _ipUserFriendlyRepresentation;
        private char[] _ipBinaryRepresentation;
        private int _subnetMask;
        private const int
            IpRangeMaxValue = 255,
            IpRangeMinValue = 0,
            IpBinaryLength = 4 * 8; // 4 blocks with 8 bits

        #endregion

        #region Methods
        /*
         * ipAddressToCheck - 192.168.1.0
         * splittedValues - "192" "168" "1" "0"
         */
        private bool IsValidIpAddress(string ipAddressToCheck)
        {
            bool isValidIp = true;
            string[] splittedValues = ipAddressToCheck.Split('.');
            foreach (var item in splittedValues)
            {
                int parsedValue = Convert.ToInt32(item);
                if (!(parsedValue >= IpRangeMinValue && parsedValue <= IpRangeMaxValue))
                {
                    isValidIp = false;
                    return isValidIp;
                }
            }
            return isValidIp;
        }
        public bool IsValidSubnetMask(int subnetMask) =>
            subnetMask >= 1 && subnetMask <= 32;

        private char[] ConvertToBinaryRepresentation(string decimalRepresentation)
        {
            string[] splittedValues = decimalRepresentation.Split('.');
            string binaryString = "";
            // splittedValues - "192" "168" "1" "0"
            foreach (var item in splittedValues)
            {
                int parsedValue = Convert.ToInt32(item);
                // Doing conversion to X format, for example 2 - Binary
                string binaryFormat = Convert.ToString(parsedValue, 2);
                binaryString += binaryFormat.PadLeft(8, '0');
            }
            return binaryString.ToCharArray();
        }

        public string GetUserFriendlyBinaryAddress()
        {
            int startIndex = 0, offsetValue = 8;
            string returnValue = "";

            while (startIndex != 32)
            {
                for (int i = startIndex; i < startIndex + offsetValue; i++)
                {
                    returnValue += _ipBinaryRepresentation[i];
                }
                returnValue += '.';
                startIndex += offsetValue;
            }
            return new string(returnValue.Take(returnValue.Length - 1).ToArray());
        }
        #endregion

        public string GetUserFriendlyBinaryMask(int subnetMask)
        {
            int startIndex = 0, offsetValue = 8;
            string returnValue = "";

            while (startIndex != 32)
            {
                for (int i = startIndex; i < startIndex + offsetValue; i++)
                {
                    returnValue += _ipBinaryRepresentation[i];
                }
                returnValue += '.';
                startIndex += offsetValue;
            }
            return new string(returnValue.Take(returnValue.Length - 1).ToArray());
        }

        #region Constructors
        public IpAddress(string inputIpValue, int subnetMask)
        {
            try
            {
                if (IsValidIpAddress(inputIpValue) && IsValidSubnetMask(subnetMask))
                {
                    _ipUserFriendlyRepresentation = inputIpValue;
                    _subnetMask = subnetMask;
                    _ipBinaryRepresentation = ConvertToBinaryRepresentation(inputIpValue);
                }
                else throw new Exception();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        #endregion
    }
}
