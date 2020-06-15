window.DateTimeSettings = {

  getLocalCTime: function () {
    return window.chrome.webview.hostObjects.sync.DateTimeSettingsInternal.getLocalCTime();
  },

  getTimeZoneCount: function () {
    return window.chrome.webview.hostObjects.sync.DateTimeSettingsInternal.getTimeZoneCount();
  },

  getTimeZoneMode: function () {
    return window.chrome.webview.hostObjects.sync.DateTimeSettingsInternal.getTimeZoneMode();
  },

  getTimeZoneOffset: function () {
    return window.chrome.webview.hostObjects.sync.DateTimeSettingsInternal.getTimeZoneOffset();
  },

  getUTCCTime: function () {
    return window.chrome.webview.hostObjects.sync.DateTimeSettingsInternal.getUTCCTime();
  },

  isBroadcastTimeKnown: function () {
    return window.chrome.webview.hostObjects.sync.DateTimeSettingsInternal.isBroadcastTimeKnown();
  },

  setCurrentDateTime: function (unixTimeStamp) {
    return window.chrome.webview.hostObjects.sync.DateTimeSettingsInternal.setCurrentDateTime(unixTimeStamp);
  },

  setTimeZoneMode: function (timeZoneMode) {
    return window.chrome.webview.hostObjects.sync.DateTimeSettingsInternal.setTimeZoneMode(timeZoneMode);
  },

  setTimeZoneOffset: function (timeZoneOffset) {
    return window.chrome.webview.hostObjects.sync.DateTimeSettingsInternal.setTimeZoneOffset(timeZoneOffset);
  }
};