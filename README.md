# Shipwreck.ValueFormatters

Primitive type wrappers to support additional format.

## Integers

- `SByteWrapper`
- `ByteWrapper`
- `Int16Wrapper`
- `UInt16Wrapper`
- `Int32Wrapper`
- `UInt32Wrapper`
- `Int64Wrapper`
- `UInt64Wrapper`

### RomanNumeralFormatter

- Supported range: `1` to `3999`
- format: `[Ll][SsAa]?`

|format|UpperCase|Additive|
|-|-|-|
|L|〇||
|l|||
|LA|〇|〇|
|la||〇|

### ChineseNumeralFormatter

- Supported range: `0` to `int.MaxValue`

- format: `(cj|jp)d?([-+<>][0-9jhsmo])*`
  - `(cj|jp)`: base charset
  - `d?`: use digit mode
  - `([-+<>][0-9jhsmo])`: Specify use `cj` charset for each char.

#### Charset

|charset|Description|
|-|-|
|`cj`|Standard Chinese Numerals|
|`jp`|Japanese Daiji Numerals (大字)|

|Number|char in format|`cj`|`jp`|
|-|-|-|-|
|0|`0`|〇|零|
|1|`1`|一|壱|
|2|`2`|二|弐|
|3|`3`|三|参|
|4|`4`|四|肆|
|5|`5`|五|伍|
|6|`6`|六|陸|
|7|`7`|七|漆|
|8|`8`|八|捌|
|9|`9`|九|玖|
|10|`j`|十|拾|
|100|`h`|百|陌|
|1,000|`s`|千|阡|
|10,000|`m`|万|萬|
|100,000,000|`o`|億|億|

#### Custom format examples

|format|Description|
|-|-|
|`jp>3-0`|Japanese Legal Daiji. Use Daiji only for 1,2 and 3|
