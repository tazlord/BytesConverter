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

namespace BytesConverter
{
    /// <summary>
    /// Conversion units.
    /// </summary>
    public enum Unit
    {
        /// <summary>
        /// Represents the raw bytes, no conversion (default).
        /// </summary>
        NONE,

        /// <summary>
        /// Represents bytes converted to kilobytes (KB).
        /// </summary>
        KILOBYTE,

        /// <summary>
        /// Represents bytes converted to kibibytes (KiB).
        /// </summary>
        KIBIBYTE,

        /// <summary>
        /// Represents bytes converted to megabytes (MB).
        /// </summary>
        MEGABYTE,

        /// <summary>
        /// Represents bytes converted to mebibytes (MiB).
        /// </summary>
        MEBIBYTE,

        /// <summary>
        /// Represents bytes converted to gigabytes (GB).
        /// </summary>
        GIGABYTE,

        /// <summary>
        /// Represents bytes converted to gibibytes (GiB).
        /// </summary>
        GIBIBYTE,

        /// <summary>
        /// Represents bytes converted to terabytes (TB).
        /// </summary>
        TERABYTE,

        /// <summary>
        /// Represents bytes converted to tebibytes (TiB).
        /// </summary>
        TEBIBYTE,

        /// <summary>
        /// Represents bytes converted to petabytes (PB).
        /// </summary>
        PETABYTE,

        /// <summary>
        /// Represents bytes converted to pebibytes (PiB).
        /// </summary>
        PEBIBYTE,

        /// <summary>
        /// Represents bytes converted to exabytes (EB).
        /// </summary>
        EXABYTE,

        /// <summary>
        /// Represents bytes converted to exbibytes (EiB).
        /// </summary>
        EXBIBYTE
    }
}
