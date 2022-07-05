<a name='assembly'></a>
# BitOfByte.Net.Transformations

## Contents

- [ITransformationsProvider](#T-BitOfByte-Net-Transformations-ITransformationsProvider 'BitOfByte.Net.Transformations.ITransformationsProvider')
  - [Get(name)](#M-BitOfByte-Net-Transformations-ITransformationsProvider-Get-System-String- 'BitOfByte.Net.Transformations.ITransformationsProvider.Get(System.String)')
  - [GetAsync(name)](#M-BitOfByte-Net-Transformations-ITransformationsProvider-GetAsync-System-String- 'BitOfByte.Net.Transformations.ITransformationsProvider.GetAsync(System.String)')
- [LiquidTransformation](#T-BitOfByte-Net-Transformations-LiquidTransformation 'BitOfByte.Net.Transformations.LiquidTransformation')
  - [Template](#P-BitOfByte-Net-Transformations-LiquidTransformation-Template 'BitOfByte.Net.Transformations.LiquidTransformation.Template')
- [TransformDefinition](#T-BitOfByte-Net-Transformations-TransformDefinition 'BitOfByte.Net.Transformations.TransformDefinition')
  - [Name](#P-BitOfByte-Net-Transformations-TransformDefinition-Name 'BitOfByte.Net.Transformations.TransformDefinition.Name')
  - [Type](#P-BitOfByte-Net-Transformations-TransformDefinition-Type 'BitOfByte.Net.Transformations.TransformDefinition.Type')
- [TransformationsProvider](#T-BitOfByte-Net-Transformations-TransformationsProvider 'BitOfByte.Net.Transformations.TransformationsProvider')
  - [#ctor(context)](#M-BitOfByte-Net-Transformations-TransformationsProvider-#ctor-Microsoft-EntityFrameworkCore-DbContext- 'BitOfByte.Net.Transformations.TransformationsProvider.#ctor(Microsoft.EntityFrameworkCore.DbContext)')
  - [Get(name)](#M-BitOfByte-Net-Transformations-TransformationsProvider-Get-System-String- 'BitOfByte.Net.Transformations.TransformationsProvider.Get(System.String)')
  - [GetAsync(name)](#M-BitOfByte-Net-Transformations-TransformationsProvider-GetAsync-System-String- 'BitOfByte.Net.Transformations.TransformationsProvider.GetAsync(System.String)')

<a name='T-BitOfByte-Net-Transformations-ITransformationsProvider'></a>
## ITransformationsProvider `type`

##### Namespace

BitOfByte.Net.Transformations

##### Summary

Interface for transformations provider

<a name='M-BitOfByte-Net-Transformations-ITransformationsProvider-Get-System-String-'></a>
### Get(name) `method`

##### Summary

Gets the TransformDefinition with then specified name.

##### Returns

TransformDefinition with the specified name if found!

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name. |

<a name='M-BitOfByte-Net-Transformations-ITransformationsProvider-GetAsync-System-String-'></a>
### GetAsync(name) `method`

##### Summary

Gets the TransformDefinition with then specified name asynchornously.

##### Returns

TransformDefinition with the specified name if found!

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name. |

<a name='T-BitOfByte-Net-Transformations-LiquidTransformation'></a>
## LiquidTransformation `type`

##### Namespace

BitOfByte.Net.Transformations

##### Summary

POCO to hold liquid transformation definition

##### See Also

- [BitOfByte.Net.Transformations.TransformDefinition](#T-BitOfByte-Net-Transformations-TransformDefinition 'BitOfByte.Net.Transformations.TransformDefinition')

<a name='P-BitOfByte-Net-Transformations-LiquidTransformation-Template'></a>
### Template `property`

##### Summary

Gets or sets the transformation template.

<a name='T-BitOfByte-Net-Transformations-TransformDefinition'></a>
## TransformDefinition `type`

##### Namespace

BitOfByte.Net.Transformations

##### Summary

Represents for Transformation

<a name='P-BitOfByte-Net-Transformations-TransformDefinition-Name'></a>
### Name `property`

##### Summary

Gets or sets the transformation name.

<a name='P-BitOfByte-Net-Transformations-TransformDefinition-Type'></a>
### Type `property`

##### Summary

Gets or sets the transformation type.

<a name='T-BitOfByte-Net-Transformations-TransformationsProvider'></a>
## TransformationsProvider `type`

##### Namespace

BitOfByte.Net.Transformations

##### Summary

TransformationsProvider implementation using EF Repository

<a name='M-BitOfByte-Net-Transformations-TransformationsProvider-#ctor-Microsoft-EntityFrameworkCore-DbContext-'></a>
### #ctor(context) `constructor`

##### Summary

Initializes a new instance of the [TransformationsProvider](#T-BitOfByte-Net-Transformations-TransformationsProvider 'BitOfByte.Net.Transformations.TransformationsProvider') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [Microsoft.EntityFrameworkCore.DbContext](#T-Microsoft-EntityFrameworkCore-DbContext 'Microsoft.EntityFrameworkCore.DbContext') | The context. |

<a name='M-BitOfByte-Net-Transformations-TransformationsProvider-Get-System-String-'></a>
### Get(name) `method`

##### Summary

Gets the TransformDefinition with then specified name.

##### Returns

TransformDefinition with the specified name if found!

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name. |

<a name='M-BitOfByte-Net-Transformations-TransformationsProvider-GetAsync-System-String-'></a>
### GetAsync(name) `method`

##### Summary

Gets the TransformDefinition with then specified name asynchornously.

##### Returns

TransformDefinition with the specified name if found!

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name. |
