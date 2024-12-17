using Script.CoreUObject;
using Script.Engine.PlatformEventsComponent;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.PlatformEventsComponent")]
	public partial class UPlatformEventsComponent : UActorComponent, IStaticClass
	{
		public FPlatformEventDelegate PlatformChangedToLaptopModeDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PlatformChangedToLaptopModeDelegate, __ReturnBuffer);

					return *(FPlatformEventDelegate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PlatformChangedToLaptopModeDelegate, __InBuffer);
				}
			}
		}

		public FPlatformEventDelegate PlatformChangedToTabletModeDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PlatformChangedToTabletModeDelegate, __ReturnBuffer);

					return *(FPlatformEventDelegate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PlatformChangedToTabletModeDelegate, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.PlatformEventsComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <see>
		/// IsInLaptopMode, IsInTabletMode
		/// </see>
		/// <returns>
		/// true for convertible laptop platforms, false otherwise.
		/// </returns>
		public virtual bool SupportsConvertibleLaptops()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __SupportsConvertibleLaptops, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <see>
		/// IsInLaptopMode, SupportsConvertibleLaptops
		/// </see>
		/// <returns>
		/// true if in tablet mode, false otherwise or if not a convertible laptop.
		/// </returns>
		public virtual bool IsInTabletMode()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsInTabletMode, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <see>
		/// IsInTabletMode, SupportsConvertibleLaptops
		/// </see>
		/// <returns>
		/// true if in laptop mode, false otherwise or if not a convertible laptop.
		/// </returns>
		public virtual bool IsInLaptopMode()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsInLaptopMode, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __PlatformChangedToLaptopModeDelegate = 0;

		private static uint __PlatformChangedToTabletModeDelegate = 0;

		private static uint __SupportsConvertibleLaptops = 0;

		private static uint __IsInTabletMode = 0;

		private static uint __IsInLaptopMode = 0;
	}
}