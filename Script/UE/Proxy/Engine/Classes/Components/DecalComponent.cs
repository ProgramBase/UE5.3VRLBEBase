using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.DecalComponent")]
	public partial class UDecalComponent : USceneComponent, IStaticClass
	{
		public UMaterialInterface DecalMaterial
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DecalMaterial, __ReturnBuffer);

					return *(UMaterialInterface*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DecalMaterial, __InBuffer);
				}
			}
		}

		public int SortOrder
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SortOrder, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SortOrder, __InBuffer);
				}
			}
		}

		public float FadeScreenSize
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FadeScreenSize, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FadeScreenSize, __InBuffer);
				}
			}
		}

		public float FadeStartDelay
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FadeStartDelay, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FadeStartDelay, __InBuffer);
				}
			}
		}

		public float FadeDuration
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FadeDuration, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FadeDuration, __InBuffer);
				}
			}
		}

		public float FadeInDuration
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FadeInDuration, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FadeInDuration, __InBuffer);
				}
			}
		}

		public float FadeInStartDelay
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FadeInStartDelay, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FadeInStartDelay, __InBuffer);
				}
			}
		}

		public bool bDestroyOwnerAfterFade
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bDestroyOwnerAfterFade, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bDestroyOwnerAfterFade, __InBuffer);
				}
			}
		}

		public FVector DecalSize
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DecalSize, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DecalSize, __InBuffer);
				}
			}
		}

		public FLinearColor DecalColor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DecalColor, __ReturnBuffer);

					return *(FLinearColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DecalColor, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.DecalComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetSortOrder(int Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = Value;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSortOrder, __InBuffer);
			}
		}

		public virtual void SetFadeScreenSize(float NewFadeScreenSize)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewFadeScreenSize;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFadeScreenSize, __InBuffer);
			}
		}

		/// <param name="StartDelay">
		/// - Time in seconds to wait before beginning to fade out the decal.
		/// </param>
		/// <param name="Duration">
		/// - Time in second for the decal to fade out.
		/// </param>
		/// <param name="DestroyOwnerAfterFade">
		/// - Should the owning actor automatically be destroyed after it is completely faded out.
		/// </param>
		public virtual void SetFadeOut(float StartDelay, float Duration, bool DestroyOwnerAfterFade = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(float*)(__InBuffer) = StartDelay;

				*(float*)(__InBuffer + 4) = Duration;

				*(bool*)(__InBuffer + 8) = DestroyOwnerAfterFade;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFadeOut, __InBuffer);
			}
		}

		public virtual void SetFadeIn(float StartDelay, float Duration)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(float*)(__InBuffer) = StartDelay;

				*(float*)(__InBuffer + 4) = Duration;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFadeIn, __InBuffer);
			}
		}

		public virtual void SetDecalMaterial(UMaterialInterface NewDecalMaterial)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewDecalMaterial?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDecalMaterial, __InBuffer);
			}
		}

		public virtual void SetDecalColor(FLinearColor Color)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Color?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDecalColor, __InBuffer);
			}
		}

		public virtual float GetFadeStartDelay()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetFadeStartDelay, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetFadeInStartDelay()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetFadeInStartDelay, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetFadeInDuration()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetFadeInDuration, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetFadeDuration()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetFadeDuration, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual UMaterialInterface GetDecalMaterial()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetDecalMaterial, __ReturnBuffer);

				return *(UMaterialInterface*)__ReturnBuffer;
			}
		}

		public virtual UMaterialInstanceDynamic CreateDynamicMaterialInstance()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __CreateDynamicMaterialInstance, __ReturnBuffer);

				return *(UMaterialInstanceDynamic*)__ReturnBuffer;
			}
		}

		private static uint __DecalMaterial = 0;

		private static uint __SortOrder = 0;

		private static uint __FadeScreenSize = 0;

		private static uint __FadeStartDelay = 0;

		private static uint __FadeDuration = 0;

		private static uint __FadeInDuration = 0;

		private static uint __FadeInStartDelay = 0;

		private static uint __bDestroyOwnerAfterFade = 0;

		private static uint __DecalSize = 0;

		private static uint __DecalColor = 0;

		private static uint __SetSortOrder = 0;

		private static uint __SetFadeScreenSize = 0;

		private static uint __SetFadeOut = 0;

		private static uint __SetFadeIn = 0;

		private static uint __SetDecalMaterial = 0;

		private static uint __SetDecalColor = 0;

		private static uint __GetFadeStartDelay = 0;

		private static uint __GetFadeInStartDelay = 0;

		private static uint __GetFadeInDuration = 0;

		private static uint __GetFadeDuration = 0;

		private static uint __GetDecalMaterial = 0;

		private static uint __CreateDynamicMaterialInstance = 0;
	}
}