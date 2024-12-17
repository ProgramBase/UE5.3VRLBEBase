﻿using Script.CoreUObject;
using Script.Library;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.GizmoConstantFrameAxisSource")]
	public partial class UGizmoConstantFrameAxisSource : UObject, IStaticClass, IGizmoAxisSource
	{
		public FVector Origin
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Origin, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Origin, __InBuffer);
				}
			}
		}

		public FVector Direction
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Direction, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Direction, __InBuffer);
				}
			}
		}

		public FVector TangentX
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TangentX, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TangentX, __InBuffer);
				}
			}
		}

		public FVector TangentY
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TangentY, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TangentY, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InteractiveToolsFramework.GizmoConstantFrameAxisSource");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <returns>
		/// true if this AxisSource has tangent vectors orthogonal to the Direction vector */
		/// </returns>
		public virtual bool HasTangentVectors()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __HasTangentVectors, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <warning>
		/// Only valid if HasTangentVectors() returns true
		/// </warning>
		public virtual void GetTangentVectors(ref FVector TangentXOut, ref FVector TangentYOut)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = TangentXOut?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TangentYOut?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[16];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetTangentVectors, __InBuffer, __OutBuffer);

				TangentXOut = *(FVector*)(__OutBuffer);

				TangentYOut = *(FVector*)(__OutBuffer + 8);

			}
		}

		/// <returns>
		/// Origin Point of axis */
		/// </returns>
		public virtual FVector GetOrigin()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetOrigin, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// Direction Vector of axis */
		/// </returns>
		public virtual FVector GetDirection()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetDirection, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <param name="EntryPoint">
		/// The entry point to start code execution at.
		/// </param>
		public override void ExecuteUbergraph(int EntryPoint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = EntryPoint;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ExecuteUbergraph, __InBuffer);
			}
		}

		private static uint __Origin = 0;

		private static uint __Direction = 0;

		private static uint __TangentX = 0;

		private static uint __TangentY = 0;

		private static uint __HasTangentVectors = 0;

		private static uint __GetTangentVectors = 0;

		private static uint __GetOrigin = 0;

		private static uint __GetDirection = 0;

		private static uint __ExecuteUbergraph = 0;
	}
}