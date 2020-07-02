WasmAppBuilderPath=/Users/naricc/workspace/runtime-pristine-2/artifacts/bin/WasmAppBuilder/Debug/net5.0/publish/WasmAppBuilder.dll
WasmRuntimePack=/Users/naricc/workspace/runtime-pristine-2/artifacts/bin/microsoft.netcore.app.runtime.browser-wasm/Debug/runtimes/browser-wasm/
WasmMainJS=/Users/naricc/workspace/runtime-pristine-2/src/mono/wasm/runtime-test.js 
MYDOTNET=/Users/naricc/workspace/runtime-pristine-2/dotnet.sh


$MYDOTNET run --framework netcoreapp5.0 --runtimes wasm --cli $MYDOTNET  --filter *Span* --wasmAppBuilderPath=$WasmAppBuilderPath --wasmRuntimePack=$WasmRuntimePack --wasmMainJS=$WasmMainJS  --keepFiles -a $HOME/benchmark-artifacts-wasm/wasm
