﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpDX;
using SharpDX.Windows;
using SharpDX.DXGI;
using SharpDX.Direct3D;
using SharpDX.Direct3D11;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Device = SharpDX.Direct3D11.Device;
using Buffer = SharpDX.Direct3D11.Buffer;

namespace TinyOculusSharpDxDemo
{
	public interface IDrawPassCtrl
	{
		/// <summary>
		/// setup render path
		/// </summary>
		/// <param name="renderTarget">render target</param>
		void StartPass(DeviceContext context, RenderTarget renderTarget);

	}
}
