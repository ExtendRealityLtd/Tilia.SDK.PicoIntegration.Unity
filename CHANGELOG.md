# Changelog

### [1.0.3](https://github.com/ExtendRealityLtd/Tilia.SDK.PicoIntegration.Unity/compare/v1.0.2...v1.0.3) (2023-03-22)

#### Bug Fixes

* **asmdef:** rename runtime asmdef ([d359554](https://github.com/ExtendRealityLtd/Tilia.SDK.PicoIntegration.Unity/commit/d359554c0c90f3d848cce3ad41b00b37f53dc395))
  > The Runtime asmdef had the incorrect name and has now been updated.
* **prefab:** reduce dominant controller check timer ([0d7d162](https://github.com/ExtendRealityLtd/Tilia.SDK.PicoIntegration.Unity/commit/0d7d16256cbf8b9a7e665f77c01f9d25f39bde3b))
  > The dominant controller moment process should have a delay interval of `0.25` so it isn't checking every frame. This improves performance.
  > 
  > The moment processor has also been moved the LateUpdate process.

### [1.0.2](https://github.com/ExtendRealityLtd/Tilia.SDK.PicoIntegration.Unity/compare/v1.0.1...v1.0.2) (2023-03-21)

#### Bug Fixes

* **prefab:** use latest Unity XR Toolkit components ([5ab7351](https://github.com/ExtendRealityLtd/Tilia.SDK.PicoIntegration.Unity/commit/5ab735175d89fdef708c92fae118e2f0fecb1dca))
  > The Pico SDK has a hard dependency on the Unity XR Toolkit but on a very old 0.9.4 preview version, which is now vastly outdated. This ensures the latest XR Toolkit version is installed and updates the prefab to use the XR Origin component instead of the XR Rig component as that is now deprecated.

### [1.0.1](https://github.com/ExtendRealityLtd/Tilia.SDK.PicoIntegration.Unity/compare/v1.0.0...v1.0.1) (2023-03-21)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 2.7.2 to 2.8.0 ([f1da10d](https://github.com/ExtendRealityLtd/Tilia.SDK.PicoIntegration.Unity/commit/f1da10d8bf0d32e37bc1379ed2ef9440aaec8040))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 2.7.2 to 2.8.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v2.7.2...v2.8.0)

## 1.0.0 (2023-03-20)

#### Features

* **structure:** add initial implementation of Pico SDK wrapper ([8d5e53a](https://github.com/ExtendRealityLtd/Tilia.SDK.PicoIntegration.Unity/commit/8d5e53a0d268814c6993e5c89b4b42ab7632bd45))
  > The Pico Integration wrapper provides a way of being able to use the Pico Integration SDK for Unity directly with the TrackedAlias so the underlying Pico SDK can be leveraged whilst still keeping a level of generics to the project.
