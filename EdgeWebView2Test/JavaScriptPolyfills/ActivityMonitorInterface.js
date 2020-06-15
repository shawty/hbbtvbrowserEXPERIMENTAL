window.ActivityMonitor = {

  getLastActivityTimestamp: function () {
    return window.chrome.webview.hostObjects.sync.ActivityMonitorInternal.GetLastActivityTimestamp();
  }

};