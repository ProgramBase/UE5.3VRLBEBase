using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraBaselineController")]
	public partial class UNiagaraBaselineController : UObject, IStaticClass
	{
		public float TestDuration
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TestDuration, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TestDuration, __InBuffer);
				}
			}
		}

		public UNiagaraEffectType EffectType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EffectType, __ReturnBuffer);

					return *(UNiagaraEffectType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EffectType, __InBuffer);
				}
			}
		}

		public ANiagaraPerfBaselineActor Owner
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Owner, __ReturnBuffer);

					return *(ANiagaraPerfBaselineActor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Owner, __InBuffer);
				}
			}
		}

		public TSoftObjectPtr<UNiagaraSystem> System
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __System, __ReturnBuffer);

					return *(TSoftObjectPtr<UNiagaraSystem>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __System, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Niagara.NiagaraBaselineController");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual bool OnTickTest()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __OnTickTest, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void OnOwnerTick(float DeltaTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = DeltaTime;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __OnOwnerTick, __InBuffer);
			}
		}

		public virtual void OnEndTest(FNiagaraPerfBaselineStats Stats)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Stats?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __OnEndTest, __InBuffer);
			}
		}

		public virtual void OnBeginTest()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __OnBeginTest);
			}
		}

		public virtual UNiagaraSystem GetSystem()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetSystem, __ReturnBuffer);

				return *(UNiagaraSystem*)__ReturnBuffer;
			}
		}

		private static uint __TestDuration = 0;

		private static uint __EffectType = 0;

		private static uint __Owner = 0;

		private static uint __System = 0;

		private static uint __OnTickTest = 0;

		private static uint __OnOwnerTick = 0;

		private static uint __OnEndTest = 0;

		private static uint __OnBeginTest = 0;

		private static uint __GetSystem = 0;
	}
}