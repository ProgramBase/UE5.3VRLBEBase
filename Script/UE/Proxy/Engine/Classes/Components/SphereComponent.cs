using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SphereComponent")]
	public partial class USphereComponent : UShapeComponent, IStaticClass
	{
		public float SphereRadius
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SphereRadius, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SphereRadius, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.SphereComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="InSphereRadius">
		/// : the new sphere radius
		/// </param>
		/// <param name="bUpdateOverlaps">
		/// : if true and this shape is registered and collides, updates touching array for owner actor.
		/// </param>
		public virtual void SetSphereRadius(float InSphereRadius, bool bUpdateOverlaps = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(float*)(__InBuffer) = InSphereRadius;

				*(bool*)(__InBuffer + 4) = bUpdateOverlaps;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSphereRadius, __InBuffer);
			}
		}

		/// <returns>
		/// the radius of the sphere, ignoring component scale.
		/// </returns>
		public virtual float GetUnscaledSphereRadius()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetUnscaledSphereRadius, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// the scale used by this shape.
		/// </returns>
		public virtual float GetShapeScale()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetShapeScale, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// the radius of the sphere, with component scale applied.
		/// </returns>
		public virtual float GetScaledSphereRadius()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetScaledSphereRadius, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		private static uint __SphereRadius = 0;

		private static uint __SetSphereRadius = 0;

		private static uint __GetUnscaledSphereRadius = 0;

		private static uint __GetShapeScale = 0;

		private static uint __GetScaledSphereRadius = 0;
	}
}