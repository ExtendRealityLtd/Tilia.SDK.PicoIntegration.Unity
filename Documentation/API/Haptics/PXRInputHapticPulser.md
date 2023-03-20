# Class PXRInputHapticPulser

Creates a single haptic pulse on a PXR\_Input.VibrateType supported haptic device.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [Controller]
  * [Duration]
  * [Frequency]
* [Methods]
  * [DoBegin()]
  * [DoCancel()]

## Details

##### Inheritance

* System.Object
* PXRInputHapticPulser

##### Namespace

* [Tilia.SDK.PicoIntegration.Haptics]

##### Syntax

```
public class PXRInputHapticPulser : HapticPulser
```

### Properties

#### Controller

The controller to pulse.

##### Declaration

```
public PXR_Input.VibrateType Controller { get; set; }
```

#### Duration

The duration to pulse [Controller] for in milliseconds.

##### Declaration

```
public int Duration { get; set; }
```

#### Frequency

The frequency between each pulse.

##### Declaration

```
public int Frequency { get; set; }
```

### Methods

#### DoBegin()

##### Declaration

```
protected override void DoBegin()
```

#### DoCancel()

##### Declaration

```
protected override void DoCancel()
```

[Tilia.SDK.PicoIntegration.Haptics]: README.md
[Controller]: PXRInputHapticPulser.md#Controller
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[Controller]: #Controller
[Duration]: #Duration
[Frequency]: #Frequency
[Methods]: #Methods
[DoBegin()]: #DoBegin
[DoCancel()]: #DoCancel
