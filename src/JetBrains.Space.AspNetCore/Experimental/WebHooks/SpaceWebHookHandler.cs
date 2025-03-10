using System.Collections.Generic;
using System.Threading.Tasks;
using JetBrains.Space.Client;

namespace JetBrains.Space.AspNetCore.Experimental.WebHooks;

/// <inheritdoc/>
public abstract class SpaceWebHookHandler
    : ISpaceWebHookHandler
{
    /// <inheritdoc/>
    public virtual Task<Commands> HandleListCommandsAsync(ListCommandsPayload payload) 
        => Task.FromResult(new Commands(new List<CommandDetail>()));
        
    /// <inheritdoc/>
    public virtual Task<MenuExtensions> HandleListMenuExtensionsAsync(ListMenuExtensionsPayload payload) 
        => Task.FromResult(new MenuExtensions(new List<MenuExtensionDetail>()));

    /// <inheritdoc/>
    public virtual Task HandleMessageAsync(MessagePayload payload)
        => Task.CompletedTask;

    /// <inheritdoc/>
    public virtual Task<ApplicationExecutionResult> HandleMessageActionAsync(MessageActionPayload payload)
        => Task.FromResult(new ApplicationExecutionResult());

    /// <inheritdoc/>
    public virtual Task<ApplicationExecutionResult> HandleMenuActionAsync(MenuActionPayload payload)
        => Task.FromResult(new ApplicationExecutionResult());
        
    /// <inheritdoc/>
    public virtual Task<ApplicationExecutionResult> HandleWebhookRequestAsync(WebhookRequestPayload payload)
        => Task.FromResult(new ApplicationExecutionResult());

    /// <inheritdoc/>
    public virtual Task<ApplicationExecutionResult> HandleNewUnfurlQueueItemsAsync(NewUnfurlQueueItemsPayload payload)
        => Task.FromResult(new ApplicationExecutionResult());
        
    /// <inheritdoc/>
    public virtual Task<ApplicationExecutionResult> HandleInitAsync(InitPayload payload)
        => Task.FromResult(new ApplicationExecutionResult());
        
    /// <inheritdoc/>
    public virtual Task<ApplicationExecutionResult> HandleChangeClientSecretRequestAsync(ChangeClientSecretPayload payload)
        => Task.FromResult(new ApplicationExecutionResult());
        
    /// <inheritdoc/>
    public virtual Task<ApplicationExecutionResult> HandleChangeServerUrlAsync(ChangeServerUrlPayload payload)
        => Task.FromResult(new ApplicationExecutionResult());

    /// <inheritdoc/>
    public virtual Task<ApplicationExecutionResult> HandleAppPublicationCheckAsync(AppPublicationCheckPayload payload)
        => Task.FromResult(new ApplicationExecutionResult());
}