//  BytesConverter is a C# utility class for converting bytes to other
//  data storage units.
//
//  Copyright (C)2023 Jose Sanchez
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <https://www.gnu.org/licenses/>.

using System;

namespace BytesConverter
{
    /// <summary>
    /// Represents a utility class for converting bytes to other storage units with optional rounding.
    /// </summary>
    public class Converter
    {
        private long _bytes;
        private int _precision;
        private Round _rounding;

        private const long _kilobyte = 1000;
        private const long _megabyte = _kilobyte * 1000;
        private const long _gigabyte = _megabyte * 1000;
        private const long _terabyte = _gigabyte * 1000;
        private const long _petabyte = _terabyte * 1000;
        private const long _kibibyte = 1024;
        private const long _gibibyte = _mebibyte * 1024;
        private const long _tebibyte = _gibibyte * 1024;
        private const long _mebibyte = _kibibyte * 1024;
        private const long _pebibyte = _tebibyte * 1024;

        /// <summary>
        /// Initializes a new instance of the <see cref="Converter"/> class.
        /// </summary>
        public Converter()
        {
            this._bytes = 0;
            this._precision = -1;
            this._rounding = Round.NONE;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Converter"/> class with a specified bytes value.
        /// </summary>
        /// <param name="bytes">Bytes value to be converted.</param>
        public Converter(long bytes)
            : this()
        {
            this._bytes = bytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Converter"/> class with a specified bytes value, rounding type, and decimal places.
        /// </summary>
        /// <param name="bytes">Bytes value to be converted.</param>
        /// <param name="rounding">The rounding type to apply.</param>
        /// <param name="precision">The number of decimal places to round to.</param>
        public Converter(long bytes, Round rounding, int precision)
            : this(bytes)
        {
            this._precision = precision;
            this._rounding = rounding;
        }

        /// <summary>
        /// Gets or sets the number of decimal places to round to.
        /// </summary>
        public int Precision
        {
            get {  return this._precision; }
            set { this._precision = value; }
        }

        /// <summary>
        /// Gets or sets the rounding type to apply during conversion.
        /// </summary>
        public Round Rounding
        {
            get { return this._rounding; }
            set { this._rounding = value; }
        }

        /// <summary>
        /// Gets or sets the bytes value to be converted.
        /// </summary>
        public long Bytes
        {
            get {  return _bytes; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Bytes value cannot be negative.");
                }
                _bytes = value;
            }
        }

        /// <summary>
        /// Gets the value of <see cref="Bytes"/> in Kilobytes (KB).
        /// </summary>
        public double Kilobyte { get { return Convert(this.Bytes, Unit.KILOBYTE, this.Rounding, this.Precision); } }

        /// <summary>
        /// Gets the value of <see cref="Bytes"/> in Kibibytes (KiB).
        /// </summary>
        public double Kibibyte { get { return Convert(this.Bytes, Unit.KIBIBYTE, this.Rounding, this.Precision); } }

        /// <summary>
        /// Gets the value of <see cref="Bytes"/> in Megabytes (MB).
        /// </summary>
        public double Megabyte { get { return Convert(this.Bytes, Unit.MEGABYTE, this.Rounding, this.Precision); } }

        /// <summary>
        /// Gets the value of <see cref="Bytes"/> in Mebibytes (MiB).
        /// </summary>
        public double Mebibyte { get { return Convert(this.Bytes, Unit.MEBIBYTE, this.Rounding, this.Precision); } }

        /// <summary>
        /// Gets the value of <see cref="Bytes"/> in Gigabytes (GB).
        /// </summary>
        public double Gigabyte { get { return Convert(this.Bytes, Unit.GIGABYTE, this.Rounding, this.Precision); } }

        /// <summary>
        /// Gets the value of <see cref="Bytes"/> in Gibibytes (GiB).
        /// </summary>
        public double Gibibyte { get { return Convert(this.Bytes, Unit.GIBIBYTE, this.Rounding, this.Precision); } }

        /// <summary>
        /// Gets the value of <see cref="Bytes"/> in Terabytes (TB).
        /// </summary>
        public double Terabyte { get { return Convert(this.Bytes, Unit.TERABYTE, this.Rounding, this.Precision); } }

        /// <summary>
        /// Gets the value of <see cref="Bytes"/> in Tebibytes (TiB).
        /// </summary>
        public double Tibibyte { get { return Convert(this.Bytes, Unit.TEBIBYTE, this.Rounding, this.Precision); } }

        /// <summary>
        /// Gets the value of <see cref="Bytes"/> in Petabytes (PB).
        /// </summary>
        public double Petabyte { get { return Convert(this.Bytes, Unit.PETABYTE, this.Rounding, this.Precision); } }

        /// <summary>
        /// Gets the value of <see cref="Bytes"/> in Pebibytes (PiB).
        /// </summary>
        public double Pebibyte { get { return Convert(this.Bytes, Unit.PEBIBYTE, this.Rounding, this.Precision); } }

        /// <summary>
        /// Convert a number to the selected data storage unit of measure.
        /// </summary>
        /// <param name="number">The number to be converted.</param>
        /// <param name="units">The desired data storage unit of measure.</param>
        /// <returns>A double precision number.</returns>
        public static double Convert(double number, Unit units)
        {
            return Calculate(number, units);
        }

        /// <summary>
        /// Convert a number to the selected data storage unit of measure.
        /// </summary>
        /// <param name="number">The number to be converted.</param>
        /// <param name="units">The desired data storage unit of measure.</param>
        /// <param name="rounding">Round the result using the selected <see cref="Round"/> method (<paramref name="precision"/> must be set).</param>
        /// <param name="precision">Round to the specified number of decimal points (must be >= 0).</param>
        /// <returns>A double precision number.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the value of <paramref name="precision"/> is less than 0.</exception>
        public static double Convert(double number, Unit units, Round rounding, int precision)
        {
            if ((int)rounding > 0 && precision < 0)
            {
                throw new ArgumentOutOfRangeException("Must set precision when rounding.");
            }

            var val = Convert(number, units);

            if (rounding == Round.NONE) { return val; }
            if (rounding == Round.ROUNDDOWN) { val = RoundDown(val, precision); }
            if (rounding == Round.ROUNDUP) { val = RoundUp(val, precision); }
            if (rounding == Round.TRUNCATE) { val = Truncate(val, precision); }

            return val;
        }

        private static double Calculate(double number, Unit units)
        {
            double val = 0;

            switch (units)
            {
                case Unit.KILOBYTE:
                    val = number / _kilobyte;
                    break;
                case Unit.KIBIBYTE:
                    val = number / _kibibyte;
                    break;
                case Unit.MEGABYTE:
                    val = number / _megabyte;
                    break;
                case Unit.MEBIBYTE:
                    val = number / _mebibyte;
                    break;
                case Unit.GIGABYTE:
                    val = number / _gigabyte;
                    break;
                case Unit.GIBIBYTE:
                    val = number / _gibibyte;
                    break;
                case Unit.TERABYTE:
                    val = number / _terabyte;
                    break;
                case Unit.TEBIBYTE:
                    val = number / _tebibyte;
                    break;
                case Unit.PETABYTE:
                    val = number / _petabyte;
                    break;
                case Unit.PEBIBYTE:
                    val = number / _pebibyte;
                    break;
            }

            return val;
        }

        private static double RoundUp(double num, int dec)
        {
            double multiplier = Math.Pow(10, dec);
            return Math.Ceiling((num * multiplier)) / multiplier;
        }

        private static double RoundDown(double num, int dec)
        {
            double multiplier = Math.Pow(10, dec);
            return Math.Floor((num * multiplier)) / multiplier;
        }

        private static double Truncate(double num, int dec)
        {
            double multiplier = Math.Pow(10, dec);
            return Math.Truncate((num * multiplier)) / multiplier;
        }
    }
}
