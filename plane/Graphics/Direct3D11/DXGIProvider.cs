﻿using Silk.NET.DXGI;

namespace plane.Graphics.Direct3D11;

public class DXGIProvider
{
    public static Lazy<DXGI> DXGI { get; private set; }

    static DXGIProvider()
    {
        DXGI = new Lazy<DXGI>(() => Silk.NET.DXGI.DXGI.GetApi());
    }
}