PlayMaker UnitTest
================

## Licensing
This package is released under LGPL license: [http://opensource.org/licenses/LGPL-3.0](http://opensource.org/licenses/LGPL-3.0)

## Description
This package provides proxies to use Unity Assertion system for UnitTesting PlayMaker

## Implementation
- Use `PlayMakerFsmVariableProxy` as a proxy between your PlayMakerFsm Component and the `AssertionComponent` from the Unity UnitTest suite.  
- Use the PlayMakerFsm.ActiveStateName public string property to also assert your Fsms.

## PlayMaker 1.8 Beta
use the compiler flag `PLAYMAKER_1_8`