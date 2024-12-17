using Script.CoreUObject;
using Script.Library;

namespace Script.EngineSettings
{
	[PathName("/Script/EngineSettings.GameMapsSettings")]
	public partial class UGameMapsSettings : UObject, IStaticClass
	{
		public FSoftObjectPath EditorStartupMap
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EditorStartupMap, __ReturnBuffer);

					return *(FSoftObjectPath*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EditorStartupMap, __InBuffer);
				}
			}
		}

		public TArray<FTemplateMapInfoOverride> EditorTemplateMapOverrides
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EditorTemplateMapOverrides, __ReturnBuffer);

					return *(TArray<FTemplateMapInfoOverride>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EditorTemplateMapOverrides, __InBuffer);
				}
			}
		}

		public FString LocalMapOptions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LocalMapOptions, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LocalMapOptions, __InBuffer);
				}
			}
		}

		public FSoftObjectPath TransitionMap
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TransitionMap, __ReturnBuffer);

					return *(FSoftObjectPath*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TransitionMap, __InBuffer);
				}
			}
		}

		public bool bUseSplitscreen
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUseSplitscreen, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUseSplitscreen, __InBuffer);
				}
			}
		}

		public ETwoPlayerSplitScreenType TwoPlayerSplitscreenLayout
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TwoPlayerSplitscreenLayout, __ReturnBuffer);

					return *(ETwoPlayerSplitScreenType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TwoPlayerSplitscreenLayout, __InBuffer);
				}
			}
		}

		public EThreePlayerSplitScreenType ThreePlayerSplitscreenLayout
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ThreePlayerSplitscreenLayout, __ReturnBuffer);

					return *(EThreePlayerSplitScreenType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ThreePlayerSplitscreenLayout, __InBuffer);
				}
			}
		}

		public EFourPlayerSplitScreenType FourPlayerSplitscreenLayout
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FourPlayerSplitscreenLayout, __ReturnBuffer);

					return *(EFourPlayerSplitScreenType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FourPlayerSplitscreenLayout, __InBuffer);
				}
			}
		}

		public bool bOffsetPlayerGamepadIds
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bOffsetPlayerGamepadIds, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bOffsetPlayerGamepadIds, __InBuffer);
				}
			}
		}

		public FSoftClassPath GameInstanceClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GameInstanceClass, __ReturnBuffer);

					return *(FSoftClassPath*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GameInstanceClass, __InBuffer);
				}
			}
		}

		public FSoftObjectPath GameDefaultMap
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GameDefaultMap, __ReturnBuffer);

					return *(FSoftObjectPath*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GameDefaultMap, __InBuffer);
				}
			}
		}

		public FSoftObjectPath ServerDefaultMap
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ServerDefaultMap, __ReturnBuffer);

					return *(FSoftObjectPath*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ServerDefaultMap, __InBuffer);
				}
			}
		}

		public FSoftClassPath GlobalDefaultGameMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GlobalDefaultGameMode, __ReturnBuffer);

					return *(FSoftClassPath*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GlobalDefaultGameMode, __InBuffer);
				}
			}
		}

		public FSoftClassPath GlobalDefaultServerGameMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GlobalDefaultServerGameMode, __ReturnBuffer);

					return *(FSoftClassPath*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GlobalDefaultServerGameMode, __InBuffer);
				}
			}
		}

		public TArray<FGameModeName> GameModeMapPrefixes
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GameModeMapPrefixes, __ReturnBuffer);

					return *(TArray<FGameModeName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GameModeMapPrefixes, __InBuffer);
				}
			}
		}

		public TArray<FGameModeName> GameModeClassAliases
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GameModeClassAliases, __ReturnBuffer);

					return *(TArray<FGameModeName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GameModeClassAliases, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EngineSettings.GameMapsSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="bSkipFirstPlayer">
		/// If set connected game pads will only be assigned to the second and subsequent players
		/// </param>
		/// <note>
		/// This value is saved to local config when changed.
		/// </note>
		public virtual void SetSkipAssigningGamepadToPlayer1(bool bSkipFirstPlayer = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bSkipFirstPlayer;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSkipAssigningGamepadToPlayer1, __InBuffer);
			}
		}

		public virtual bool GetSkipAssigningGamepadToPlayer1()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetSkipAssigningGamepadToPlayer1, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static UGameMapsSettings GetGameMapsSettings()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetGameMapsSettings, __ReturnBuffer);

				return *(UGameMapsSettings*)__ReturnBuffer;
			}
		}

		private static uint __EditorStartupMap = 0;

		private static uint __EditorTemplateMapOverrides = 0;

		private static uint __LocalMapOptions = 0;

		private static uint __TransitionMap = 0;

		private static uint __bUseSplitscreen = 0;

		private static uint __TwoPlayerSplitscreenLayout = 0;

		private static uint __ThreePlayerSplitscreenLayout = 0;

		private static uint __FourPlayerSplitscreenLayout = 0;

		private static uint __bOffsetPlayerGamepadIds = 0;

		private static uint __GameInstanceClass = 0;

		private static uint __GameDefaultMap = 0;

		private static uint __ServerDefaultMap = 0;

		private static uint __GlobalDefaultGameMode = 0;

		private static uint __GlobalDefaultServerGameMode = 0;

		private static uint __GameModeMapPrefixes = 0;

		private static uint __GameModeClassAliases = 0;

		private static uint __SetSkipAssigningGamepadToPlayer1 = 0;

		private static uint __GetSkipAssigningGamepadToPlayer1 = 0;

		private static uint __GetGameMapsSettings = 0;
	}
}