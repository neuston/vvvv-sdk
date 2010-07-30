﻿using System;
using VVVV.PluginInterfaces.V1;
using VVVV.Utils.VMath;

namespace VVVV.PluginInterfaces.V2.Output
{

	public class Vector2DOutputPin : ValueOutputPin<Vector2D>
	{
		public Vector2DOutputPin(IPluginHost host, OutputAttribute attribute)
			:base(host, attribute)
		{
		}
		
		unsafe public override Vector2D this[int index] 
		{
			get
			{
				throw new NotSupportedException();
			}
			set
			{
				fixed (double* ptr = FData)
				{
					((Vector2D*)ptr)[index] = value;
				}
			}
		}
	}
	
	public class Vector3DOutputPin : ValueOutputPin<Vector3D>
	{
		public Vector3DOutputPin(IPluginHost host, OutputAttribute attribute)
			:base(host, attribute)
		{
		}
		
		unsafe public override Vector3D this[int index] 
		{
			get
			{
				throw new NotSupportedException();
			}
			set
			{
				fixed (double* ptr = FData)
				{
					((Vector3D*)ptr)[index] = value;
				}
			}
		}
	}
	
	public class Vector4DOutputPin : ValueOutputPin<Vector4D>
	{
		public Vector4DOutputPin(IPluginHost host, OutputAttribute attribute)
			:base(host, attribute)
		{
		}
		
		unsafe public override Vector4D this[int index] 
		{
			get
			{
				throw new NotSupportedException();
			}
			set
			{
				fixed (double* ptr = FData)
				{
					((Vector4D*)ptr)[index] = value;
				}
			}
		}
	}

}