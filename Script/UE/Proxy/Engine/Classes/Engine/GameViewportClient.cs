using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.GameViewportClient")]
	public partial class UGameViewportClient : UScriptViewportClient, IStaticClass
	{
		public UConsole ViewportConsole
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ViewportConsole, __ReturnBuffer);

					return *(UConsole*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ViewportConsole, __InBuffer);
				}
			}
		}

		public TArray<FDebugDisplayProperty> DebugProperties
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DebugProperties, __ReturnBuffer);

					return *(TArray<FDebugDisplayProperty>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DebugProperties, __InBuffer);
				}
			}
		}

		public int MaxSplitscreenPlayers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MaxSplitscreenPlayers, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MaxSplitscreenPlayers, __InBuffer);
				}
			}
		}

		public UWorld World
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __World, __ReturnBuffer);

					return *(UWorld*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __World, __InBuffer);
				}
			}
		}

		public UGameInstance GameInstance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GameInstance, __ReturnBuffer);

					return *(UGameInstance*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GameInstance, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.GameViewportClient");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SSSwapControllers()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __SSSwapControllers);
			}
		}

		/// <deprecated>
		/// Use the cvar "r.DebugSafeZone.Mode=1".
		/// </deprecated>
		public virtual void ShowTitleSafeArea()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ShowTitleSafeArea);
			}
		}

		public virtual void SetConsoleTarget(int PlayerIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = PlayerIndex;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetConsoleTarget, __InBuffer);
			}
		}

		private static uint __ViewportConsole = 0;

		private static uint __DebugProperties = 0;

		private static uint __MaxSplitscreenPlayers = 0;

		private static uint __World = 0;

		private static uint __GameInstance = 0;

		private static uint __SSSwapControllers = 0;

		private static uint __ShowTitleSafeArea = 0;

		private static uint __SetConsoleTarget = 0;
	}
}