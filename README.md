# **Bit34 Presenter - UI Abstraction Library for Unity**

# **Table of contents**
- [What is it?](#what-is-it)
- [Requirements](#requirements)


## **What is it?**
This is an ui abstraction library that uses Director(MVP Library) for abstraction between program an Unity ui system.


## **Requirements**

`com.bit34games.director` is declared in `package.json`, so it is resolved for
you — through the Bit34 Package Manager, since Unity does not follow git
dependencies of a git package.

**DOTween has to be in the project already.** `ScreenView` and
`PresenterUnityHelpers` use `DG.Tweening` for screen transitions. DOTween is
distributed as a Unity asset rather than a UPM package, so it cannot be named
in `package.json`: import it from the Asset Store (or the Package Manager, for
DOTween Pro) before adding this library, or the package will not compile.


TBA...
