using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraDataChannelWriter")]
	public partial class UNiagaraDataChannelWriter : UObject, IStaticClass
	{
		public UNiagaraDataChannelHandler Owner
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Owner, __ReturnBuffer);

					return *(UNiagaraDataChannelHandler*)__ReturnBuffer;
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

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Niagara.NiagaraDataChannelWriter");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void WriteVector4(FName VarName, int Index, FVector4 InData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = VarName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Index;

				*(nint*)(__InBuffer + 12) = InData?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __WriteVector4, __InBuffer);
			}
		}

		public virtual void WriteVector2D(FName VarName, int Index, FVector2D InData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = VarName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Index;

				*(nint*)(__InBuffer + 12) = InData?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __WriteVector2D, __InBuffer);
			}
		}

		public virtual void WriteVector(FName VarName, int Index, FVector InData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = VarName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Index;

				*(nint*)(__InBuffer + 12) = InData?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __WriteVector, __InBuffer);
			}
		}

		public virtual void WriteSpawnInfo(FName VarName, int Index, FNiagaraSpawnInfo InData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = VarName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Index;

				*(nint*)(__InBuffer + 12) = InData?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __WriteSpawnInfo, __InBuffer);
			}
		}

		public virtual void WriteQuat(FName VarName, int Index, FQuat InData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = VarName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Index;

				*(nint*)(__InBuffer + 12) = InData?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __WriteQuat, __InBuffer);
			}
		}

		public virtual void WritePosition(FName VarName, int Index, FVector InData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = VarName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Index;

				*(nint*)(__InBuffer + 12) = InData?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __WritePosition, __InBuffer);
			}
		}

		public virtual void WriteLinearColor(FName VarName, int Index, FLinearColor InData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = VarName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Index;

				*(nint*)(__InBuffer + 12) = InData?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __WriteLinearColor, __InBuffer);
			}
		}

		public virtual void WriteInt(FName VarName, int Index, int InData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = VarName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Index;

				*(int*)(__InBuffer + 12) = InData;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __WriteInt, __InBuffer);
			}
		}

		public virtual void WriteFloat(FName VarName, int Index, double InData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = VarName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Index;

				*(double*)(__InBuffer + 12) = InData;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __WriteFloat, __InBuffer);
			}
		}

		public virtual void WriteBool(FName VarName, int Index, bool InData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(nint*)(__InBuffer) = VarName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Index;

				*(bool*)(__InBuffer + 12) = InData;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __WriteBool, __InBuffer);
			}
		}

		public virtual int Num()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __Num, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual bool InitWrite(FNiagaraDataChannelSearchParameters SearchParams, int Count, bool bVisibleToGame = true, bool bVisibleToCPU = true, bool bVisibleToGPU = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[15];

				*(nint*)(__InBuffer) = SearchParams?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Count;

				*(bool*)(__InBuffer + 12) = bVisibleToGame;

				*(bool*)(__InBuffer + 13) = bVisibleToCPU;

				*(bool*)(__InBuffer + 14) = bVisibleToGPU;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __InitWrite, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __Owner = 0;

		private static uint __WriteVector4 = 0;

		private static uint __WriteVector2D = 0;

		private static uint __WriteVector = 0;

		private static uint __WriteSpawnInfo = 0;

		private static uint __WriteQuat = 0;

		private static uint __WritePosition = 0;

		private static uint __WriteLinearColor = 0;

		private static uint __WriteInt = 0;

		private static uint __WriteFloat = 0;

		private static uint __WriteBool = 0;

		private static uint __Num = 0;

		private static uint __InitWrite = 0;
	}
}