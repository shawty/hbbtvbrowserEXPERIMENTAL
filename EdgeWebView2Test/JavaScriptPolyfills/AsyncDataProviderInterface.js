window.AsyncDataProvider = {

  COMPLETED_WITH_INCOMPLETE_DATA_SET: 2,
  COMPLETED_WITH_SUCCESS: 0,
  FAILED: 1,

  addEventListener: function (eventName, eventHandler) {
    window.hbbtvBrowser.internals.addCallback(eventName, eventHandler);
    return window.chrome.webview.hostObjects.sync.AsyncDataProviderInternal.addEventListener(eventName);
  },

  getChannelList: function (minifiedVersion = false) {
    return window.chrome.webview.hostObjects.sync.AsyncDataProviderInternal.getChannelList(minifiedVersion);
  },

  removeEventListener: function (eventName, eventHandler) {
    window.hbbtvBrowser.internals.removeCallback(eventName, eventHandler);
    return window.chrome.webview.hostObjects.sync.AsyncDataProviderInternal.removeEventListener(eventName);
  },

  removeEventListener: function (eventName) {
    window.hbbtvBrowser.internals.removeCallback(eventName, eventHandler);
    return window.chrome.webview.hostObjects.sync.AsyncDataProviderInternal.removeEventListener(eventName);
  }

};