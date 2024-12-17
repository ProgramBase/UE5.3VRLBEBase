using Script.CoreUObject;
using Script.Library;
using Script.Niagara;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraPythonEmitter")]
	public partial class UNiagaraPythonEmitter : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NiagaraEditor.NiagaraPythonEmitter");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetProperties(FVersionedNiagaraEmitterData Data)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Data?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetProperties, __InBuffer);
			}
		}

		public virtual bool HasModule(FString ModuleName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ModuleName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __HasModule, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual FVersionedNiagaraEmitterData GetProperties()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetProperties, __ReturnBuffer);

				return *(FVersionedNiagaraEmitterData*)__ReturnBuffer;
			}
		}

		public virtual UNiagaraEmitter GetObject()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetObject, __ReturnBuffer);

				return *(UNiagaraEmitter*)__ReturnBuffer;
			}
		}

		public virtual TArray<UNiagaraPythonModule> GetModules()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetModules, __ReturnBuffer);

				return *(TArray<UNiagaraPythonModule>*)__ReturnBuffer;
			}
		}

		public virtual UNiagaraPythonModule GetModule(FString ModuleName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ModuleName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetModule, __InBuffer, __ReturnBuffer);

				return *(UNiagaraPythonModule*)__ReturnBuffer;
			}
		}

		private static uint __SetProperties = 0;

		private static uint __HasModule = 0;

		private static uint __GetProperties = 0;

		private static uint __GetObject = 0;

		private static uint __GetModules = 0;

		private static uint __GetModule = 0;
	}
}