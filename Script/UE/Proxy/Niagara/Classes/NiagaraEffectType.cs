using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraEffectType")]
	public partial class UNiagaraEffectType : UObject, IStaticClass
	{
		public bool bAllowCullingForLocalPlayers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAllowCullingForLocalPlayers, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAllowCullingForLocalPlayers, __InBuffer);
				}
			}
		}

		public ENiagaraScalabilityUpdateFrequency UpdateFrequency
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __UpdateFrequency, __ReturnBuffer);

					return *(ENiagaraScalabilityUpdateFrequency*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = (int)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __UpdateFrequency, __InBuffer);
				}
			}
		}

		public ENiagaraCullReaction CullReaction
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CullReaction, __ReturnBuffer);

					return *(ENiagaraCullReaction*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = (int)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CullReaction, __InBuffer);
				}
			}
		}

		public UNiagaraSignificanceHandler SignificanceHandler
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SignificanceHandler, __ReturnBuffer);

					return *(UNiagaraSignificanceHandler*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SignificanceHandler, __InBuffer);
				}
			}
		}

		public FNiagaraSystemScalabilitySettingsArray SystemScalabilitySettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SystemScalabilitySettings, __ReturnBuffer);

					return *(FNiagaraSystemScalabilitySettingsArray*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SystemScalabilitySettings, __InBuffer);
				}
			}
		}

		public FNiagaraEmitterScalabilitySettingsArray EmitterScalabilitySettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EmitterScalabilitySettings, __ReturnBuffer);

					return *(FNiagaraEmitterScalabilitySettingsArray*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EmitterScalabilitySettings, __InBuffer);
				}
			}
		}

		public TArray<UNiagaraValidationRule> ValidationRules
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ValidationRules, __ReturnBuffer);

					return *(TArray<UNiagaraValidationRule>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ValidationRules, __InBuffer);
				}
			}
		}

		public TArray<UNiagaraValidationRuleSet> ValidationRuleSets
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ValidationRuleSets, __ReturnBuffer);

					return *(TArray<UNiagaraValidationRuleSet>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ValidationRuleSets, __InBuffer);
				}
			}
		}

		public UNiagaraBaselineController PerformanceBaselineController
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PerformanceBaselineController, __ReturnBuffer);

					return *(UNiagaraBaselineController*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PerformanceBaselineController, __InBuffer);
				}
			}
		}

		public FNiagaraPerfBaselineStats PerfBaselineStats
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PerfBaselineStats, __ReturnBuffer);

					return *(FNiagaraPerfBaselineStats*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PerfBaselineStats, __InBuffer);
				}
			}
		}

		public FGuid PerfBaselineVersion
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PerfBaselineVersion, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PerfBaselineVersion, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Niagara.NiagaraEffectType");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __bAllowCullingForLocalPlayers = 0;

		private static uint __UpdateFrequency = 0;

		private static uint __CullReaction = 0;

		private static uint __SignificanceHandler = 0;

		private static uint __SystemScalabilitySettings = 0;

		private static uint __EmitterScalabilitySettings = 0;

		private static uint __ValidationRules = 0;

		private static uint __ValidationRuleSets = 0;

		private static uint __PerformanceBaselineController = 0;

		private static uint __PerfBaselineStats = 0;

		private static uint __PerfBaselineVersion = 0;
	}
}