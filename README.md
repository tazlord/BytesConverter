# BytesConverter

## Overview

`BytesConverter` is a C# utility class for converting bytes to other data storage units with optional rounding. It provides flexibility by allowing users to specify rounding options and decimal precision during conversion. It also includes a static method, `Convert()`, for inline conversions.

## Examples

```csharp
using BytesConverter;

// Class instance example

var converter = new Converter(1024); // 1024 bytes
var kilobytes = converter.Kilobyte; // 1.024 KB
Console.WriteLine($"1024 bytes in kilobytes: {kilobytes} KB");

// Static method example

var num = 1024; // 1024 bytes
Console.WriteLine($"1024 bytes in kilobytes: {Converter.Convert(num, Unit.KILOBYTE)} KB"); // 1.024 KB
Console.WriteLine($"1024 bytes in kilobytes: {Converter.Convert(num, Unit.KILOBYTE, Round.ROUNDUP, 2} KB"); // 1.02 KB
```

## Usage

### Class: Converter

The main class.

#### Constructors

- `public Converter()`: Initializes a new instance of the Converter class.
- `public Converter(long bytes)`: Initializes a new instance of the Converter class with a specified bytes value.
- `public Converter(long bytes, Round rounding, int precision)`: Initializes a new instance of the Converter class with a specified bytes value, rounding type, and decimal places.

#### Properties

- `public long Bytes`: Gets or sets the bytes value to be converted.
- `public Round Rounding`: Gets or sets the rounding type to apply during conversion.
- `public int Precision`: Gets or sets the number of decimal places to round to (must be set when using Rounding).
- `public double Kilobyte`: Gets the value of Bytes in Kilobytes (KB).
- `public double Kibibyte`: Gets the value of Bytes in Kibibytes (KiB).
- `public double Megabyte`: Gets the value of Bytes in Megabytes (MB).
- `public double Mebibyte`: Gets the value of Bytes in Mebibytes (MiB).
- `public double Gigabyte`: Gets the value of Bytes in Gigabytes (GB).
- `public double Gibibyte`: Gets the value of Bytes in Gibibytes (GiB).
- `public double Terabyte`: Gets the value of Bytes in Terabytes (TB).
- `public double Tibibyte`: Gets the value of Bytes in Tebibytes (TiB).
- `public double Petabyte`: Gets the value of Bytes in Petabytes (PB).
- `public double Pebibyte`: Gets the value of Bytes in Pebibytes (PiB).

#### Methods

- `public static double Convert(long bytes, Unit units)`: Convert bytes to the selected data storage units.
- `public static double Convert(long bytes, Unit units, Round rounding, int precision)`: Convert bytes to the selected data storage units with rounding.
  
#### Enums

##### `Round`

Specifies rounding options for use in the Converter class.

- `NONE`: No rounding will be applied (default).
- `ROUNDUP`: Rounds up to the nearest number at the specified decimal place (traditional).
- `ROUNDDOWN`: Rounds down to the nearest number at the specified decimal place.
- `TRUNCATE`: Truncates the value to the specified decimal place without rounding.

##### `Unit`

Represents popular storage units for bytes conversion.

- `NONE`: Represents the raw bytes, no conversion (default).
- `KILOBYTE`: Represents bytes converted to kilobytes (KB).
- `KIBIBYTE`: Represents bytes converted to kibibytes (KiB).
- `MEGABYTE`: Represents bytes converted to megabytes (MB).
- `MEBIBYTE`: Represents bytes converted to mebibytes (MiB).
- `GIGABYTE`: Represents bytes converted to gigabytes (GB).
- `GIBIBYTE`: Represents bytes converted to gibibytes (GiB).
- `TERABYTE`: Represents bytes converted to terabytes (TB).
- `TEBIBYTE`: Represents bytes converted to tebibytes (TiB).
- `PETABYTE`: Represents bytes converted to petabytes (PB).
- `PEBIBYTE`: Represents bytes converted to pebibytes (PiB).
