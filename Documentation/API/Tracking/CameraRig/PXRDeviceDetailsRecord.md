# Class PXRDeviceDetailsRecord

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [HasPassThroughCamera]
  * [IsConnected]
  * [NodeType]
  * [Priority]
  * [XRNodeType]
* [Methods]
  * [CheckIsConnected()]
  * [ConvertXRNodeToPXRController(XRNode)]
  * [DisablePassThrough()]
  * [EnablePassThrough()]
  * [GetPriority()]
  * [SetNodeType(Int32)]

## Details

##### Inheritance

* System.Object
* PXRDeviceDetailsRecord

##### Namespace

* [Tilia.SDK.PicoIntegration.Tracking.CameraRig]

##### Syntax

```
public class PXRDeviceDetailsRecord : BaseDeviceDetailsRecord
```

### Properties

#### HasPassThroughCamera

##### Declaration

```
public override bool HasPassThroughCamera { get; protected set; }
```

#### IsConnected

##### Declaration

```
public override bool IsConnected { get; protected set; }
```

#### NodeType

The Node Type for the record.

##### Declaration

```
public XRNode NodeType { get; set; }
```

#### Priority

##### Declaration

```
public override int Priority { get; protected set; }
```

#### XRNodeType

##### Declaration

```
public override XRNode XRNodeType { get; protected set; }
```

### Methods

#### CheckIsConnected()

Checks if the device is connected.

##### Declaration

```
protected virtual bool CheckIsConnected()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | Whether the device is connected. |

#### ConvertXRNodeToPXRController(XRNode)

Converts a given XRNode to the appropriate PXR\_Input.Controller enum.

##### Declaration

```
protected virtual PXR_Input.Controller? ConvertXRNodeToPXRController(XRNode node)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| XRNode | node | The XR Node to convert. |

##### Returns

| Type | Description |
| --- | --- |
| System.Nullable<PXR\_Input.Controller\> | The converted controller enum. |

#### DisablePassThrough()

##### Declaration

```
protected override void DisablePassThrough()
```

#### EnablePassThrough()

##### Declaration

```
protected override void EnablePassThrough()
```

#### GetPriority()

Gets the priority of the device.

##### Declaration

```
protected virtual int GetPriority()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Int32 | The priority of this device. |

#### SetNodeType(Int32)

Sets the [NodeType].

##### Declaration

```
public virtual void SetNodeType(int index)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index | The index of the XRNode. |

[Tilia.SDK.PicoIntegration.Tracking.CameraRig]: README.md
[NodeType]: PXRDeviceDetailsRecord.md#NodeType
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[HasPassThroughCamera]: #HasPassThroughCamera
[IsConnected]: #IsConnected
[NodeType]: #NodeType
[Priority]: #Priority
[XRNodeType]: #XRNodeType
[Methods]: #Methods
[CheckIsConnected()]: #CheckIsConnected
[ConvertXRNodeToPXRController(XRNode)]: #ConvertXRNodeToPXRControllerXRNode
[DisablePassThrough()]: #DisablePassThrough
[EnablePassThrough()]: #EnablePassThrough
[GetPriority()]: #GetPriority
[SetNodeType(Int32)]: #SetNodeTypeInt32
