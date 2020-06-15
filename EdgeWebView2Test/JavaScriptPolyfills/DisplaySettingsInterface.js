window.DisplaySettings = {

  getPanelHeight: function () {
    return window.chrome.webview.hostObjects.sync.DisplaySettingsInternal.getPanelHeight();
  },

  getPanelWidth: function () {
    return window.chrome.webview.hostObjects.sync.DisplaySettingsInternal.getPanelWidth();
  },

  is3DModeActive: function () {
    return window.chrome.webview.hostObjects.sync.DisplaySettingsInternal.is3DModeActive();
  }

};