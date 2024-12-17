using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.BoxComponent")]
	public partial class UBoxComponent : UShapeComponent, IStaticClass
	{
		public FVector BoxExtent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BoxExtent, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BoxExtent, __InBuffer);
				}
			}
		}

		public float LineThickness
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LineThickness, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LineThickness, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.BoxComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetLineThickness(float Thickness)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Thickness;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLineThickness, __InBuffer);
			}
		}

		/// <param name="InBoxExtent">
		/// : new extent (radius) for the box.
		/// </param>
		/// <param name="bUpdateOverlaps">
		/// : if true and this shape is registered and collides, updates touching array for owner actor.
		/// </param>
		public virtual void SetBoxExtent(FVector InBoxExtent, bool bUpdateOverlaps = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InBoxExtent?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bUpdateOverlaps;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetBoxExtent, __InBuffer);
			}
		}

		/// <returns>
		/// the box extent, ignoring component scale.
		/// </returns>
		public virtual FVector GetUnscaledBoxExtent()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetUnscaledBoxExtent, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// the box extent, scaled by the component scale.
		/// </returns>
		public virtual FVector GetScaledBoxExtent()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetScaledBoxExtent, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		private static uint __BoxExtent = 0;

		private static uint __LineThickness = 0;

		private static uint __SetLineThickness = 0;

		private static uint __SetBoxExtent = 0;

		private static uint __GetUnscaledBoxExtent = 0;

		private static uint __GetScaledBoxExtent = 0;
	}
}