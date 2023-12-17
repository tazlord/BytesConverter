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
    /// Specifies rounding options for use in the <see cref="Converter"/> class.
    /// </summary>
    public enum Round
    {
        /// <summary>
        /// No rounding will be applied (default).
        /// </summary>
        NONE,

        /// <summary>
        /// Rounds down to the nearest number at the specified decimal place.
        /// </summary>
        ROUNDDOWN,

        /// <summary>
        /// Rounds up to the nearest number at the specified decimal place.
        /// </summary>
        ROUNDUP,

        /// <summary>
        /// Truncates the value to the specified decimal place without rounding.
        /// </summary>
        TRUNCATE
    }
}
