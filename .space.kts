job("Run NUKE build") {
    container("mcr.microsoft.com/dotnet/core/sdk:3.1-bionic") {
        resources {
            cpu = 2048
            memory = 2048
        }

        env.set("JB_SPACE_NUGET_URL", Params("SPACEDOTNET_NUGET_URL"))
        env.set("JB_SPACE_CLIENT_TOKEN", Secrets("SPACEDOTNET_NUGET_APIKEY"))

        env.set("JB_SPACE_PUBLIC_NUGET_URL", Params("spacedotnet_public_nuget_url"))
        env.set("JB_SPACE_PUBLIC_CLIENT_TOKEN", Secrets("spacedotnet_public_nuget_apikey"))

        shellScript {
            content = """
            	/bin/bash ./build.sh
            """
        }
    }
}