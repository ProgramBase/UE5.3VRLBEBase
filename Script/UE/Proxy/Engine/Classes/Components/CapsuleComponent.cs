using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.CapsuleComponent")]
	public partial class UCapsuleComponent : UShapeComponent, IStaticClass
	{
		public float CapsuleHalfHeight
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CapsuleHalfHeight, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CapsuleHalfHeight, __InBuffer);
				}
			}
		}

		public float CapsuleRadius
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CapsuleRadius, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CapsuleRadius, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.CapsuleComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="InRadius">
		/// : radius of end-cap hemispheres and center cylinder.
		/// </param>
		/// <param name="InHalfHeight">
		/// : half-height, from capsule center to end of top or bottom hemisphere. 
		/// </param>
		/// <param name="bUpdateOverlaps">
		/// : if true and this shape is registered and collides, updates touching array for owner actor.
		/// </param>
		public virtual void SetCapsuleSize(float InRadius, float InHalfHeight, bool bUpdateOverlaps = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(float*)(__InBuffer) = InRadius;

				*(float*)(__InBuffer + 4) = InHalfHeight;

				*(bool*)(__InBuffer + 8) = bUpdateOverlaps;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetCapsuleSize, __InBuffer);
			}
		}

		/// <param name="Radius">
		/// : radius of end-cap hemispheres and center cylinder.
		/// </param>
		/// <param name="bUpdateOverlaps">
		/// : if true and this shape is registered and collides, updates touching array for owner actor.
		/// </param>
		public virtual void SetCapsuleRadius(float Radius, bool bUpdateOverlaps = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(float*)(__InBuffer) = Radius;

				*(bool*)(__InBuffer + 4) = bUpdateOverlaps;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetCapsuleRadius, __InBuffer);
			}
		}

		/// <param name="HalfHeight">
		/// : half-height, from capsule center to end of top or bottom hemisphere. 
		/// </param>
		/// <param name="bUpdateOverlaps">
		/// : if true and this shape is registered and collides, updates touching array for owner actor.
		/// </param>
		public virtual void SetCapsuleHalfHeight(float HalfHeight, bool bUpdateOverlaps = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(float*)(__InBuffer) = HalfHeight;

				*(bool*)(__InBuffer + 4) = bUpdateOverlaps;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetCapsuleHalfHeight, __InBuffer);
			}
		}

		/// <param name="OutRadius">
		/// Radius of the capsule, ignoring component scaling.
		/// </param>
		/// <param name="OutHalfHeightWithoutHemisphere">
		/// Half-height of the capsule, scaled by the component scale. Excludes the hemisphere end cap.
		/// </param>
		/// <returns>
		/// The capsule radius and half-height (excluding hemisphere end cap), ignoring component scaling.
		/// </returns>
		public virtual void GetUnscaledCapsuleSize_WithoutHemisphere(ref float OutRadius, ref float OutHalfHeightWithoutHemisphere)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(float*)(__InBuffer) = OutRadius;

				*(float*)(__InBuffer + 4) = OutHalfHeightWithoutHemisphere;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetUnscaledCapsuleSize_WithoutHemisphere, __InBuffer, __OutBuffer);

				OutRadius = *(float*)(__OutBuffer);

				OutHalfHeightWithoutHemisphere = *(float*)(__OutBuffer + 4);

			}
		}

		/// <param name="OutRadius">
		/// Radius of the capsule, scaled by the component scale.
		/// </param>
		/// <param name="OutHalfHeight">
		/// Half-height of the capsule, scaled by the component scale. Includes the hemisphere end cap.
		/// </param>
		/// <returns>
		/// The capsule radius and half-height scaled by the component scale.
		/// </returns>
		public virtual void GetUnscaledCapsuleSize(ref float OutRadius, ref float OutHalfHeight)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(float*)(__InBuffer) = OutRadius;

				*(float*)(__InBuffer + 4) = OutHalfHeight;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetUnscaledCapsuleSize, __InBuffer, __OutBuffer);

				OutRadius = *(float*)(__OutBuffer);

				OutHalfHeight = *(float*)(__OutBuffer + 4);

			}
		}

		/// <returns>
		/// the capsule radius, ignoring component scaling.
		/// </returns>
		public virtual float GetUnscaledCapsuleRadius()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetUnscaledCapsuleRadius, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// The capsule half-height minus radius, ignoring component scaling.
		/// </returns>
		public virtual float GetUnscaledCapsuleHalfHeight_WithoutHemisphere()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetUnscaledCapsuleHalfHeight_WithoutHemisphere, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// The capsule radius, ignoring component scaling.
		/// </returns>
		public virtual float GetUnscaledCapsuleHalfHeight()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetUnscaledCapsuleHalfHeight, __ReturnBuffer);

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

		/// <param name="OutRadius">
		/// Radius of the capsule, ignoring component scaling.
		/// </param>
		/// <param name="OutHalfHeightWithoutHemisphere">
		/// Half-height of the capsule, scaled by the component scale. Excludes the hemisphere end cap.
		/// </param>
		/// <returns>
		/// The capsule radius and half-height scaled by the component scale.
		/// </returns>
		public virtual void GetScaledCapsuleSize_WithoutHemisphere(ref float OutRadius, ref float OutHalfHeightWithoutHemisphere)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(float*)(__InBuffer) = OutRadius;

				*(float*)(__InBuffer + 4) = OutHalfHeightWithoutHemisphere;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetScaledCapsuleSize_WithoutHemisphere, __InBuffer, __OutBuffer);

				OutRadius = *(float*)(__OutBuffer);

				OutHalfHeightWithoutHemisphere = *(float*)(__OutBuffer + 4);

			}
		}

		/// <param name="OutRadius">
		/// Radius of the capsule, scaled by the component scale.
		/// </param>
		/// <param name="OutHalfHeight">
		/// Half-height of the capsule, scaled by the component scale. Includes the hemisphere end cap.
		/// </param>
		/// <returns>
		/// The capsule radius and half-height scaled by the component scale.
		/// </returns>
		public virtual void GetScaledCapsuleSize(ref float OutRadius, ref float OutHalfHeight)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(float*)(__InBuffer) = OutRadius;

				*(float*)(__InBuffer + 4) = OutHalfHeight;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetScaledCapsuleSize, __InBuffer, __OutBuffer);

				OutRadius = *(float*)(__OutBuffer);

				OutHalfHeight = *(float*)(__OutBuffer + 4);

			}
		}

		/// <returns>
		/// The capsule radius scaled by the component scale.
		/// </returns>
		public virtual float GetScaledCapsuleRadius()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetScaledCapsuleRadius, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// The capsule half-height minus radius, scaled by the component scale.
		/// </returns>
		public virtual float GetScaledCapsuleHalfHeight_WithoutHemisphere()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetScaledCapsuleHalfHeight_WithoutHemisphere, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// The capsule half-height scaled by the component scale.
		/// </returns>
		public virtual float GetScaledCapsuleHalfHeight()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetScaledCapsuleHalfHeight, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		private static uint __CapsuleHalfHeight = 0;

		private static uint __CapsuleRadius = 0;

		private static uint __SetCapsuleSize = 0;

		private static uint __SetCapsuleRadius = 0;

		private static uint __SetCapsuleHalfHeight = 0;

		private static uint __GetUnscaledCapsuleSize_WithoutHemisphere = 0;

		private static uint __GetUnscaledCapsuleSize = 0;

		private static uint __GetUnscaledCapsuleRadius = 0;

		private static uint __GetUnscaledCapsuleHalfHeight_WithoutHemisphere = 0;

		private static uint __GetUnscaledCapsuleHalfHeight = 0;

		private static uint __GetShapeScale = 0;

		private static uint __GetScaledCapsuleSize_WithoutHemisphere = 0;

		private static uint __GetScaledCapsuleSize = 0;

		private static uint __GetScaledCapsuleRadius = 0;

		private static uint __GetScaledCapsuleHalfHeight_WithoutHemisphere = 0;

		private static uint __GetScaledCapsuleHalfHeight = 0;
	}
}